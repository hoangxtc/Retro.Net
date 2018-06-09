﻿using System.Collections.Generic;
using Retro.Net.Timing;

namespace Retro.Net.Z80.Core.Decode
{
    /// <summary>
    /// A decoded block of CPU op-codes.
    /// </summary>
    public class DecodedBlock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecodedBlock" /> class.
        /// </summary>
        /// <param name="operations">The operations.</param>
        /// <param name="timings">The timings.</param>
        /// <param name="halt">if set to <c>true</c> [ends on a HALT instruction].</param>
        /// <param name="stop">if set to <c>true</c> [ends on a STOP instruction].</param>
        /// <param name="length">The total block length including literals, displacements etc.</param>
        /// <param name="address">The address.</param>
        public DecodedBlock(ushort address, int length, ICollection<Operation> operations, InstructionTimings timings, bool halt, bool stop)
        {
            Address = address;
            Length = length;
            Operations = operations;
            Timings = timings;
            Halt = halt;
            Stop = stop;
        }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public ushort Address { get; }

        /// <summary>
        /// Gets the total block length including literals, displacements etc.
        /// </summary>
        public int Length { get; }

        /// <summary>
        /// Gets the operations.
        /// </summary>
        public ICollection<Operation> Operations { get; }

        /// <summary>
        /// Gets the timings.
        /// </summary>
        public InstructionTimings Timings { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="DecodedBlock"/> ends on a HALT instruction.
        /// </summary>
        public bool Halt { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="DecodedBlock"/> ends on a STOP instruction.
        /// </summary>
        public bool Stop { get; }
    }
}