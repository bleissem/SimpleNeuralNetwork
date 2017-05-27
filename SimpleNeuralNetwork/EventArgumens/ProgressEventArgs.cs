﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeuralNetwork.EventArgumens
{
    public class ProgressEventArgs : EventArgs
    {
        public string Status { get; private set; }

        public ProgressEventArgs(string status)
        {
            Status = status;
        }
    }
}
