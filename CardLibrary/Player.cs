﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Player
    {
        public int Id { get; }
        public Hand Hand { get; }

        public Player(int id, string[] cards)
        {
            Id = id;
            Hand = new Hand(cards);
        }
    }
}
