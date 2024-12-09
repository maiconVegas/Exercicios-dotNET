﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.bird_watcher
{
    internal class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek() => new[] {0, 2, 5, 3, 7, 8, 4};

        public int Today() => birdsPerDay[birdsPerDay.Length - 1];

        public void IncrementTodaysCount() => this.birdsPerDay[birdsPerDay.Length - 1]++;

        public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

        public int CountForFirstDays(int numberOfDays) => birdsPerDay.Take(numberOfDays).Sum();

        public int BusyDays() => birdsPerDay.Count(day => day >= 5);

    }
}
