﻿using SimpleNeuralNetwork.AI.Interfaces;
using SimpleNeuralNetwork.AI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNeuralNetwork.AI
{
    public class NeuralNetworkRunner
    {
        private IFeedForward _feedForward;

        public NeuralNetworkRunner(IFeedForward feedForward)
        {
            _feedForward = feedForward;
        }

        public double[] Run(NeuralNetwork neuralNetwork, double[] inputData)
        {
            _feedForward.Compute(neuralNetwork, inputData);
            return neuralNetwork.OutputNeurons.Select(a => a.Value).ToArray();
        }
    }
}