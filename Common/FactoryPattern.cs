﻿namespace Common
{
    public static class SortFactory
    {
        public static SortStrategy StrategyGenerator(string sortStrategy)
        {
            switch (sortStrategy)
            {
                case "InsertionSort":
                    return new InsertionSort();
                case "BubbleSort":
                    return new BubbleSort();
                case "SelectionSort":
                    return new SelectionSort();
                default:
                    return null;
            }
        }
    }
}