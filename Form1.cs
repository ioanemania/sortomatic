using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sort_O_Matic
{
    public partial class SortOMaticForm : Form
    {
        private int[] array;
        private Graphics graphics;
        private Rectangle graphicsRectangle;

        // backgroundWorker is used for processing the sorting algorithms
        private BackgroundWorker backgroundWorker;

        // Manual Reset Event is used to allow pausing the execution of the backgroundWorker
        private System.Threading.ManualResetEvent mre;

        // Used to check if the sortToggleButton is set to Start or Pause
        private bool paused = true;

        public SortOMaticForm()
        {
            InitializeComponent();

            InitializeSortListBox();
            InitializePanelGraphics();
            InitializeArray();
            InitializeBackgroundWorker();

            mre = new System.Threading.ManualResetEvent(true);
        }

        #region Initializers

        // Populate sortListBox with Available sorting algorithms 
        // Must be called before InitializeSorterTimeListView
        private void InitializeSortListBox()
        {
            sortListBox.SelectionMode = SelectionMode.MultiSimple;
            sortListBox.Items.Add(new BubbleSorter());
            sortListBox.Items.Add(new InsertionSorter());
            sortListBox.Items.Add(new SelectionSorter());
            sortListBox.Items.Add(new CocktailSorter());
        }

        // Store graphicsPanel's initial graphics state
        private void InitializePanelGraphics()
        {
            graphics = graphicsPanel.CreateGraphics();
            graphicsRectangle = graphicsPanel.DisplayRectangle;
        }

        // Populate the initial sorting array
        private void InitializeArray()
        {
            array = new int[graphicsRectangle.Width];
            RandomizeArray();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorker_ProgressChange);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
        }
        #endregion

        #region Event Handlers

        // Repaint the graphicsPanel with the array content 
        // Used when calling Refresh(), from EventHandlers
        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);
            for (int i = 0; i < array.Length; i++)
            {
                g.FillRectangle(new SolidBrush(Color.Black), i, graphicsRectangle.Height - array[i], 1, 1);
            }
        }

        private void randomArrayButton_Click(object sender, EventArgs e)
        {
            RandomizeArray();
            Refresh();
            CancelWorker(backgroundWorker);
        }

        private void descendingArrayButton_Click(object sender, EventArgs e)
        {
            DescendingArray();
            Refresh();
            CancelWorker(backgroundWorker);
        }

        private void ascendingArrayButton_Click(object sender, EventArgs e)
        {
            AscendingArray();
            Refresh();
            CancelWorker(backgroundWorker);
        }

        // Handles the logic behind start/pause button
        private void sortToggleButton_Click(object sender, EventArgs e)
        {
            paused = !paused;

            if (paused)
            {
                // Enable Array Buttons
                randomArrayButton.Enabled = true;
                ascendingArrayButton.Enabled = true;
                descendingArrayButton.Enabled = true;

                sortToggleButton.Text = "Start";

                // Force the worker thread to block
                mre.Reset();
            }
            else
            {
                // Disable Array Buttons
                randomArrayButton.Enabled = false;
                ascendingArrayButton.Enabled = false;
                descendingArrayButton.Enabled = false;

                sortToggleButton.Text = "Pause";

                if (backgroundWorker.IsBusy)
                    // Allow the worker thread to continue
                    mre.Set();
                else
                {
                    sorterTimeListBox.Items.Clear();
                    // Launch the backgroundWorker on initial Start button click
                    backgroundWorker.RunWorkerAsync(sortListBox.SelectedItems.Cast<ISorter>().ToList());
                }
            }

        }

        #endregion

        #region Background Worker Handlers
        // Executes each selected sorting algorithm from sortListBox one-by-one
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            // Save the original array
            int[] original_array = (int[]) array.Clone();
            foreach (ISorter sorter in e.Argument as List<ISorter>)
            {
                // On each new sorter restore the original array
                array = (int[]) original_array.Clone();

                foreach (int[] ij in sorter.Sort(array))
                {
                    // Update the screen after each swap
                    var (i, j) = (ij[0], ij[1]);
                    graphics.FillRectangle(new SolidBrush(Color.White), i, 0, 1, graphicsRectangle.Height);
                    graphics.FillRectangle(new SolidBrush(Color.White), j, 0, 1, graphicsRectangle.Height);

                    graphics.FillRectangle(new SolidBrush(Color.Black), i, graphicsRectangle.Height - array[i], 1, 1);
                    graphics.FillRectangle(new SolidBrush(Color.Black), j, graphicsRectangle.Height - array[j], 1, 1);

                    // Pause the worker and the sorter timer if mre signal is set
                    sorter.Stopwatch.Stop();
                    mre.WaitOne(System.Threading.Timeout.Infinite);
                    sorter.Stopwatch.Start();

                    // Finish the thread if cancellation was requested
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                }

                worker.ReportProgress(0);
            }
        }

        // Reset UI state after worker has finished all sorting
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Enable Array Buttons
            randomArrayButton.Enabled = true;
            ascendingArrayButton.Enabled = true;
            descendingArrayButton.Enabled = true;

            sortToggleButton.Text = "Start";
            mre.Set();
            paused = true;

            foreach (ISorter sorter in sortListBox.Items)
                sorter.Stopwatch.Reset();
        }

        // On each finished sorter update the sorterTimeListBox with the sorters elapsed time
        private void BackgroundWorker_ProgressChange(object sender, ProgressChangedEventArgs e)
        {
            sorterTimeListBox.Items.Clear();
            foreach (ISorter sorter in sortListBox.Items)
            {
                var timespan = TimeSpan.FromMilliseconds(sorter.Stopwatch.ElapsedMilliseconds);
                sorterTimeListBox.Items.Add(timespan.Milliseconds == 0 ? "" : $"{timespan.Seconds}.{timespan.Milliseconds}s");
            }
            Refresh();
        }
        #endregion

        #region Helper Functions
        private void CancelWorker(BackgroundWorker worker)
        {
            if (worker.IsBusy)
            {
                worker.CancelAsync();
                mre.Set(); // The worker might be blocked, allow it to proceed and cancel
            }
        }

        private void RandomizeArray()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, graphicsRectangle.Height);
            }
        }

        private void AscendingArray()
        {
            for (int i = 0; i < graphicsRectangle.Height; i++)
            {
                array[i] = i;
            }

            for (int i = graphicsRectangle.Height; i < array.Length; i++)
            {
                array[i] = graphicsRectangle.Height - 1;
            }
        }

        private void DescendingArray()
        {
            for (int i = 0; i < graphicsRectangle.Height; i++)
            {
                array[i] = graphicsRectangle.Height - i;
            }

            for (int i = graphicsRectangle.Height; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
        #endregion
    }
}
