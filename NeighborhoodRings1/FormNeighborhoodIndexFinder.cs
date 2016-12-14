using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NeighbourRings1
{
    public partial class FormNeighborhoodIndexFinder : Form
    {
        public FormNeighborhoodIndexFinder()
        {
            InitializeComponent();
        }

        private void FormNeighbourIndexFinder_Load(object sender, EventArgs e)
        {
            LoadDefaultSettings();
        }

        private void LoadDefaultSettings()
        {
            cbCellCountX.SelectedIndex = 0;
            cbCellCountY.SelectedIndex = 0;
        }

        /// <summary>
        /// Returns total cell count for the specific X * Y grid.
        /// </summary>
        /// <param name="cellCountX">Number of grid rows.</param>
        /// <param name="cellCountY">Number of grid columns</param>
        /// <returns>Total cell count, integer.</returns>
        private int GetCellCount(int cellCountX, int cellCountY)
        {
            return cellCountX * cellCountY;
        }

        /// <summary>
        /// Returns the max possible neighborhood rings, for the specific X * Y grid.
        /// </summary>
        /// <param name="cellCountX">Number of grid rows.</param>
        /// <param name="cellCountY">Number of grid columns</param>
        /// <returns>Max possible rings, for every cell i nthe X * Y grid, integer.</returns>
        private int GetMaxNeighborhoodRings(int cellCountX, int cellCountY)
        {
            return Math.Max(cellCountX - 1, cellCountY - 1);
        }
        
        /// <summary>
        /// Returns all the moore neighbour indices in a List collection, given a specific grid X * Y,
        /// specific cell index and specific moore neighborhood ring.
        /// </summary>
        /// <param name="cellX">Row, X index of the cell.</param>
        /// <param name="cellY">Column, Y index of the cell.</param>
        /// <param name="neighbourRing">Moore neighborhood ring.</param>
        /// <returns>List of cell points, indices of all the existing neighbour indices of the specific grid
        /// and the specific cell & moore neighborhood ring.</returns>
        private List<CellPoint> GetNeighboursIndicesList(int cellX, int cellY, int neighbourRing)
        {
            HashSet<CellPoint> returningCellNeighbourseHashSet = new HashSet<CellPoint>();

            int cellCountX;
            int cellCountY;
            if (Int32.TryParse(cbCellCountX.Text, out cellCountX) &&
                Int32.TryParse(cbCellCountY.Text, out cellCountY))
            {

                CellPoint topLeft = new CellPoint
                {
                    X = cellX - neighbourRing,
                    Y = cellY - neighbourRing
                };
                CellPoint topRight = new CellPoint
                {
                    X = cellX - neighbourRing,
                    Y = cellY + neighbourRing
                };
                CellPoint bottomLeft = new CellPoint
                {
                    X = cellX + neighbourRing,
                    Y = cellY - neighbourRing
                };
                CellPoint bottomRight = new CellPoint
                {
                    X = cellX + neighbourRing,
                    Y = cellY + neighbourRing
                };
                
                if (topLeft.X >= 0)
                {
                    int y = topLeft.Y + 1;
                    if (y < 0)
                        y = 0;
                    int maxY = topRight.Y;
                    if (maxY > cellCountY)
                        maxY = cellCountY;
                    for (; y < maxY; y++) // Skips the corner points
                    {
                        CellPoint currentCellPoint = new CellPoint {X = topLeft.X, Y = y}; // Top row
                        if (IsPointInGrid(currentCellPoint, cellCountX, cellCountY))
                            returningCellNeighbourseHashSet.Add(currentCellPoint);
                    }
                }

                if (bottomLeft.X >= 0)
                {
                    int y = bottomLeft.Y + 1;
                    if (y < 0)
                        y = 0;
                    int maxY = bottomRight.Y;
                    if (maxY > cellCountY)
                        maxY = cellCountY;
                    for (; y < maxY; y++) // Skips the corner points
                    {
                        CellPoint currentCellPoint = new CellPoint {X = bottomLeft.X, Y = y}; // Bottom row
                        if (IsPointInGrid(currentCellPoint, cellCountX, cellCountY))
                            returningCellNeighbourseHashSet.Add(currentCellPoint);
                    }
                }

                if (topLeft.Y >= 0)
                {
                    int x = topLeft.X;
                    if (x < 0)
                        x = 0;
                    int maxX = bottomLeft.X;
                    if (maxX > cellCountX)
                        maxX = cellCountX;
                    for (; x <= maxX; x++) // Adds all the corner points
                    {
                        CellPoint currentCellPoint = new CellPoint {X = x, Y = topLeft.Y}; // Left row
                        if (IsPointInGrid(currentCellPoint, cellCountX, cellCountY))
                            returningCellNeighbourseHashSet.Add(currentCellPoint);
                    }
                }

                if (topRight.Y >= 0)
                {
                    int x = topRight.X;
                    if (x < 0)
                        x = 0;
                    int maxX = bottomRight.X;
                    if (maxX > cellCountX)
                        maxX = cellCountX;
                    for (; x <= maxX; x++) // Adds all the corner points
                    {
                        CellPoint currentCellPoint = new CellPoint {X = x, Y = topRight.Y}; // Right row
                        if (IsPointInGrid(currentCellPoint, cellCountX, cellCountY))
                            returningCellNeighbourseHashSet.Add(currentCellPoint);
                    }
                }
            }

            return new List<CellPoint>(returningCellNeighbourseHashSet);
        }

        /// <summary>
        /// Checks if the specific cell point has valid indices within the 2 dimensional
        /// space of a given X * Y grid.
        /// </summary>
        /// <param name="currentCellPoint">The X, Y indices of the cell in check.</param>
        /// <param name="cellCountX">Count of rows, X of the grid.</param>
        /// <param name="cellCountY">Count of columns, Y of the grid.</param>
        /// <returns>True if the cell is indeed inside the grid of size X * Y.</returns>
        private bool IsPointInGrid(CellPoint currentCellPoint, int cellCountX, int cellCountY)
        {
            bool returningIsInGrid = currentCellPoint.X >= 0 && currentCellPoint.Y >= 0 & currentCellPoint.X < cellCountX &&
                currentCellPoint.Y < cellCountY;

            return returningIsInGrid;
        }

        /// <summary>
        /// Updates the Combo box ui controls of the cell indices and neighbourhood.
        /// </summary>
        private void UpdateControls()
        {
            int cellCountX;
            int cellCountY;
            if (Int32.TryParse(cbCellCountX.Text, out cellCountX) &&
                Int32.TryParse(cbCellCountY.Text, out cellCountY))
            {
                if (cellCountX > 0 && cellCountY > 0)
                {
                    txtCellCount.Text = GetCellCount(cellCountX, cellCountY).ToString();

                    int maxNeighbourRings = GetMaxNeighborhoodRings(cellCountX, cellCountY);

                    cbNeighbourRing.Items.Clear();
                    for (int i = 1; i <= maxNeighbourRings; i++)
                        cbNeighbourRing.Items.Add(i);
                    if (cbNeighbourRing.Items.Count > 0)
                        cbNeighbourRing.SelectedIndex = 0;

                    cbCellIndexI.Items.Clear();
                    for (int i = 0; i < cellCountX; i++)
                        cbCellIndexI.Items.Add(i);
                    if (cbCellIndexI.Items.Count > 0)
                        cbCellIndexI.SelectedIndex = 0;

                    cbCellIndexJ.Items.Clear();
                    for (int i = 0; i < cellCountY; i++)
                        cbCellIndexJ.Items.Add(i);
                    if (cbCellIndexJ.Items.Count > 0)
                        cbCellIndexJ.SelectedIndex = 0;

                }
            }
        }

        private void cbCellCountX_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void cbCellCountY_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        /// <summary>
        /// Updates the Combo box ui controls of the neighbours.
        /// </summary>
        private void UpdateNeighbours()
        {
            int maxNeighbourCells = 0;
            int neighbourRing;
            if (Int32.TryParse(cbNeighbourRing.Text, out neighbourRing))
            {
                if (neighbourRing > 0)
                    maxNeighbourCells = 2 * neighbourRing * 4;
            }

            txtMaxNeibhourCells.Text = maxNeighbourCells.ToString();
        }

        private void cbNeighbourRing_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNeighbours();

            UpdateCellIndexNeighbours();
        }

        /// <summary>
        /// Updates the Combo box ui controls of the cell indices.
        /// </summary>
        private void UpdateCellIndexNeighbours()
        {
            int neighbourRing;
            if (Int32.TryParse(cbNeighbourRing.Text, out neighbourRing))
            {
                int cellX;
                int cellY;
                if (Int32.TryParse(cbCellIndexI.Text, out cellX) &&
                    Int32.TryParse(cbCellIndexJ.Text, out cellY))
                {
                    if (cellX >= 0 && cellY >= 0)
                    {
                        List<CellPoint> neighbourCellPoints = GetNeighboursIndicesList(cellX, cellY, neighbourRing);

                        txtNeighbourCells.Text = neighbourCellPoints.Count.ToString();

                    }
                }
            }
        }

        private void cbCellIndexI_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCellIndexNeighbours();
        }

        private void cbCellIndexJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCellIndexNeighbours();
        }

        private void btnFindNeighbours_Click(object sender, EventArgs e)
        {
            // TODO: Output/store all the neighbourhood indices.
        }
    }

    class CellPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
