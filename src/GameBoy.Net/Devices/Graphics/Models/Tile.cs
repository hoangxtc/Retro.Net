﻿namespace GameBoy.Net.Devices.Graphics.Models
{
    /// <summary>
    /// 8*8=64 byte GameBoy GPU background/window/sprite tile structure.
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tile"/> class.
        /// </summary>
        /// <param name="palette">The palette.</param>
        public Tile(Palette[] palette)
        {
            Palette = palette;
        }

        /// <summary>
        /// Gets the tile palette.
        /// </summary>
        public Palette[] Palette { get; }

        /// <summary>
        /// Gets the palette value at the specified row and column.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        public Palette Get(int row, int column) => Palette[row * 8 + column];
    }
}