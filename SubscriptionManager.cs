﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumballMachine
{
    class SubscriptionManager
    {
        List<Gum> nextGumBatch = new List<Gum>();
        
        public SubscriptionManager() { }
        /// <summary>
        /// Delivers the new batch of gums to the user
        /// </summary>
        /// <returns>List of Gum with the correct amount of each flavour</returns>
        public List<Gum> DeliverGums()
        {
            GetNextBatchReady();
            return nextGumBatch;
        }
        /// <summary>
        /// Create the new batch, with the correct amount
        /// </summary>
        void GetNextBatchReady()
        {
            nextGumBatch.Clear();
            for (int i = 0; i < 14; i++)
            {
                Gum gum = new Gum();
                gum.Flavour = "Blueberry";
                nextGumBatch.Add(gum);
            }
            for (int i = 0; i < 6; i++)
            {
                Gum gum = new Gum();
                gum.Flavour = "Blackberry";
                nextGumBatch.Add(gum);
            }
            for (int i = 0; i < 12; i++)
            {
                Gum gum = new Gum();
                gum.Flavour = "TuttiFrutti";
                nextGumBatch.Add(gum);
            }
            for (int i = 0; i < 10; i++)
            {
                Gum gum = new Gum();
                gum.Flavour = "Orange";
                nextGumBatch.Add(gum);
            }
            for (int i = 0; i < 8; i++)
            {
                Gum gum = new Gum();
                gum.Flavour = "Strawberry";
                nextGumBatch.Add(gum);
            }
            for (int i = 0; i < 5; i++)
            {
                Gum gum = new Gum();
                gum.Flavour = "Apple";
                nextGumBatch.Add(gum);
            }
        }
    }
}
