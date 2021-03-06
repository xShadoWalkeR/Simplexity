﻿using System;

namespace SImplexityv2._0 {

    /// <summary>
    /// Checks all winning conditions.
    /// </summary>
    public class CheckWin {
        /// <summary>
        /// Checks if four equal pieces are in a row, horizontally.
        /// Or if four pieces of the same color are in a row, horizontally.
        /// </summary>
        /// <param name="grid">Stores the contents of the grid.</param>
        /// <param name="win">Stores information about the winning player.</param>
        /// <returns>Winning condition.</returns>
        public static string CheckHorizontal(PieceTypes[,] grid, string win) {

            // Initiate empty variables.
            int piecesInRow = 0;
            string shape = "";
            string color = "";

            /* Check if there are 4 equal pieces in a row to verify 
             * the winner in horizontal.*/
            for (int i = 6; i >= 0; i--) {
                for (int j = 6; j > 0; j--) {
                    piecesInRow++;
                    shape = CheckShape(grid[i, j]);
                    /* Verify if there is a bar on the current grid position 
                     * or if there is a bar on the next grid position.*/
                    if (grid[i, j] == PieceTypes.Bar || grid[i, j - 1] == PieceTypes.Bar) {
                        piecesInRow = 0;
                        /* Verifies if the piece in the current position
                         * is the same as the one next to it, on the left.*/
                } else if (shape != CheckShape(grid[i, j - 1])) {
                        piecesInRow = 0;
                    }
                    /* If the shape is 'Square' the winner is player 2,
                     * else the winnner is player 1.*/
                    if (piecesInRow == 3) {
                        win = shape == "Square" ? "Player 2 Wins!" : "Player 1 Wins!";
                        return win;
                    }
                }
            }

            /* Check if there are 4 pieces in a row of the same color 
             * to verify the winner in horizontal.*/
            for (int i = 6; i >= 0; i--) {
                for (int j = 6; j > 0; j--) {
                    piecesInRow++;
                    color = CheckColor(grid[i, j]);
                    /* Verify if there is a bar on the current grid position 
                     * or if there is a bar on the next grid position.*/
                    if (grid[i, j] == PieceTypes.Bar || grid[i, j - 1] == PieceTypes.Bar) {
                        piecesInRow = 0;
                      /* Verifies if the piece in the current position is 
                       * the same color as the one next to it, on the left.*/
                    } else if (color != CheckColor(grid[i, j - 1])) {
                        piecesInRow = 0;
                    }
                    /* If the color is 'Red' the winner is player 2,
                     * else the winnner is player 1.*/
                    if (piecesInRow == 3) {
                        win = color == "Red" ? "Player 2 Wins!" : "Player 1 Wins!";
                        return win;
                    }
                }
            }
            return win;
        }

        /// <summary>
        /// Checks if four equal pieces are in a row, vertically.
        /// Or if four pieces of the same color are in a row, vertically.
        /// </summary>
        /// <param name="grid">Stores the contents of the grid.</param>
        /// <param name="win">Stores information about the winning player.</param>
        /// <returns>Winning condition.</returns>
        public static string CheckVertical(PieceTypes[,] grid, string win) {

            // Initiate empty variables.
            int piecesInRow = 0;
            string shape = "";
            string color = "";

            /* Check if there are 4 equal pieces in a row to verify 
             * the winner in vertical.*/
            for (int i = 6; i >= 0; i--) {
                for (int j = 6; j > 0; j--) {
                    piecesInRow++;
                    shape = CheckShape(grid[j, i]);
                    /* Verify if there is a bar on the current grid position 
                     * or if there is a bar on the next grid position.*/
                    if (grid[j, i] == PieceTypes.Bar || grid[j - 1, i] == PieceTypes.Bar) {
                        piecesInRow = 0;
                        /* Verifies if the piece in the current position
                         * is the same shape as the one on top of it.*/
                    } else if (shape != CheckShape(grid[j - 1, i])) {
                        piecesInRow = 0;
                    }
                    /* If the shape is 'Square' the winner is player 2,
                     * else the winnner is player 1.*/
                    if (piecesInRow == 3) {
                        win = shape == "Square" ? "Player 2 Wins!" : "Player 1 Wins!";
                        return win;
                    }
                }
            }

            /* Check if there are 4 pieces in a row of the same color 
             * to verify the winner in vertical.*/
            for (int i = 6; i >= 0; i--) {
                for (int j = 6; j > 0; j--) {
                    piecesInRow++;
                    color = CheckColor(grid[j, i]);
                    /* Verify if there is a bar on the current grid position 
                     * or if there is a bar on the next grid position.*/
                    if (grid[j, i] == PieceTypes.Bar || grid[j - 1, i] == PieceTypes.Bar) {
                        piecesInRow = 0;
                        /* Verifies if the piece in the current position is 
                           * the same color as the one on top of it.*/
                    } else if (color != CheckColor(grid[j - 1, i])) {
                        piecesInRow = 0;
                    }
                    /* If the color is 'Red' the winner is player 2,
                     * else the winnner is player 1.*/
                    if (piecesInRow == 3) {
                        win = color == "Red" ? "Player 2 Wins!" : "Player 1 Wins!";
                        return win;
                    }
                }
            }
            return win;
        }

        /// <summary>
        /// Checks if four pieces are in a row diagonally to the left
        /// </summary>
        /// <param name="grid">Stores the contents of the grid.</param>
        /// <param name="win">Stores information about the winning player.</param>
        /// <returns>Winning condition.</returns>
        public static string CheckDiagonalLeft(PieceTypes[,] grid, string win) {
            /* Initiate 'i' and 'j' at the wanted values to do a
             * diagonal check*/
            int i = 2, j = 6;

            // Initiate empty variables.
            int piecesInRow = 0;
            string shape = "";
            string color = "";

            /* Check if there 4 equal pieces in a row to verify 
             * the winner diagonally to the left.*/
            for (int a = 0; a <= 6; a++) {
                    if (a <= 3) {
                        i++;
                    } else if (a > 3) {
                        j--;
                    }
                for (int b = 0; b < i && b < j; b++) {
                    piecesInRow++;
                    shape = CheckShape(grid[i - b, j - b]);
                    /* Verify if there is a bar on the current grid position 
                     * or if there is a bar on the next grid position.*/
                    if (grid[i - b, j - b] == PieceTypes.Bar ||
                        grid[i - b - 1, j - b - 1] == PieceTypes.Bar) {
                        piecesInRow = 0;
                        /* Verifies if the piece in the current position is the 
                         * same shape as the one diagonally to it, on the left.*/
                    } else if (shape != CheckShape(grid[i - b - 1, j - b - 1])) {
                        piecesInRow = 0;
                    }
                    /* If the shape is 'Square' the winner is player 2,
                     * else the winnner is player 1.*/
                    if (piecesInRow == 3) {
                        win = shape == "Square" ? "Player 2 Wins!" : "Player 1 Wins!";
                        return win;
                    }
                }
            }

            // Reset the values of 'i' and 'j'.
            i = 2;
            j = 6;

            /* Check if there 4 pieces in a row of the same color to 
             * verify the winner diagonally to the left.*/
            for (int a = 0; a <= 6; a++) {
                    if (a <= 3) {
                        i++;
                    } else if (a > 3) {
                        j--;
                    }
                for (int b = 0; b < i && b < j; b++) {
                    piecesInRow++;
                    color = CheckColor(grid[i - b, j - b]);
                    /* Verify if there is a bar on the current grid position 
                     * or if there is a bar on the next grid position.*/
                    if (grid[i - b, j - b] == PieceTypes.Bar ||
                        grid[i - b - 1, j - b - 1] == PieceTypes.Bar) {
                        piecesInRow = 0;
                        /* Verifies if the piece in the current position is the 
                         * same color as the one diagonally to it, on the left.*/
                    } else if (color != CheckColor(grid[i - b - 1, j - b - 1])) {
                        piecesInRow = 0;
                    }
                    /* If the color is 'Red' the winner is player 2,
                     * else the winnner is player 1.*/
                    if (piecesInRow == 3) {
                        win = color == "Red" ? "Player 2 Wins!" : "Player 1 Wins!";
                        return win;
                    }
                }
            }

            return win;
        }

        /// <summary>
        /// Checks if four pieces are in a row diagonally to the right.
        /// </summary>
        /// <param name="grid">Stores the contents of the grid.</param>
        /// <param name="win">Stores information about the winning player.</param>
        /// <returns>Winning condition.</returns>
        public static string CheckDiagonalRight(PieceTypes[,] grid, string win) {
            /* Initiate 'i' and 'j' at the wanted values to do a
             * diagonal check*/
            int i = 2, j = 0;

            // Initiate empty variables.
            int piecesInRow = 0;
            string shape = "";
            string color = "";

            /* Check if there 4 equal pieces in a row to verify the 
             * winner diagonally to the right.*/
            for (int a = 0; a <= 6; a++) {
                    if (a <= 3) {
                        i++;
                    } else if (a > 3) {
                        j++;
                    }
                for (int b = 0; b < i && b >= j; b++) {
                    piecesInRow++;
                    shape = CheckShape(grid[i - b, j + b]);
                    /* Verify if there is a bar on the current grid position 
                    *or if there is a bar on the next grid position.*/
                    if (grid[i - b, j + b] == PieceTypes.Bar ||
                        grid[i - b - 1, j + b + 1] == PieceTypes.Bar) {
                        piecesInRow = 0;
                        /* Verifies if the piece in the current position is the 
                           * same shape as the one diagonally to it, on the right.*/
                    } else if (shape != CheckShape(grid[i - b - 1, j + b + 1])) {
                        piecesInRow = 0;
                    }
                    /* If the shape is 'Square' the winner is player 2,
                     * else the winnner is player 1.*/
                    if (piecesInRow == 3) {
                        win = shape == "Square" ? "Player 2 Wins!" : "Player 1 Wins!";
                        return win;
                    }
                }
            }
            i = 2;
            j = 0;

            /* Check if there 4 pieces in a row of the same color to 
             * verify the winner diagonally to the right.*/
            for (int a = 0; a <= 6; a++) {
                    if (a <= 3) {
                        i++;
                    } else if (a > 3) {
                        j++;
                    }
                for (int b = 0; b < i && b >= j; b++) {
                    piecesInRow++;
                    color = CheckColor(grid[i - b, j + b]);
                    /* Verify if there is a bar on the current grid position 
                     * or if there is a bar on the next grid position.*/
                    if (grid[i - b, j + b] == PieceTypes.Bar ||
                        grid[i - b - 1, j + b + 1] == PieceTypes.Bar) {
                        piecesInRow = 0;
                        /* Verifies if the piece in the current position is the 
                           * same color as the one diagonally to it, on the right.*/
                    } else if (color != CheckColor(grid[i - b - 1, j + b + 1])) {
                        piecesInRow = 0;
                    }
                    /* If the color is 'Red' the winner is player 2,
                     * else the winnner is player 1.*/
                    if (piecesInRow == 4) {
                        win = color == "Red" ? "Player 2 Wins!" : "Player 1 Wins!";
                        return win;
                    }
                }
            }
            return win;
        }

        /// <summary>
        /// Verifies if the value of each piece is divisible by two,
        /// in order to determine its shape.
        /// </summary>
        /// <param name="currentPiece">Currently selected piece.</param>
        /// <returns>Piece Shape</returns>
        private static string CheckShape(PieceTypes currentPiece) {
            string shape = "";
            if ((int)currentPiece % 2 == 0) {
                shape = "Square";
            } else if ((int)currentPiece % 2 != 0) {
                shape = "Circle";
            }
            return shape;
        }

        /// <summary>
        /// Verifies the 'int' value of a pice from the enum, 
        /// to determine its color.
        /// </summary>
        /// <param name="currentPiece">Currently selected piece.</param>
        /// <returns>Piece Color</returns>
        private static string CheckColor(PieceTypes currentPiece) {
            string color = "";
            if ((int)currentPiece == 0 || (int)currentPiece == 1) {
                color = "Red";
            } else if ((int)currentPiece == 2 || (int)currentPiece == 3) {
                color = "White";
            }
            return color;
        }
    }
}
