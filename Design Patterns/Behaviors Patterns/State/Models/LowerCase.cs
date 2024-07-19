﻿using Behaviors_Patterns.State.Contracts;

namespace Behaviors_Patterns.State.Models
{
    public class LowerCase : IWriteState
    {
        public void Write(string text)
        {
            Console.WriteLine(text.ToLower());
        }
    }
}
