using System;
namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Helper
    {
        public int[] CalculateCalories(int[] fats, int[] carbs, int[] proteins)
        {
            int size = fats.Length;
            int[] calories = new int[size];
            for(int i = 0; i < size; i++)
            {
                calories[i] = (fats[i] * 9) + ((carbs[i] + proteins[i]) * 5);
            }
            return calories;
        }

        public void maximum(bool[] indices, int[] value, int size)
        {
            int maxval = int.MinValue;
            for(int i = 0; i < size; i++)
            {
                if(indices[i] && maxval < value[i])
                    maxval = value[i];
            }

            for(int i = 0; i < size; i++)
            {
                if(indices[i] && maxval != value[i])
                    indices[i] = false;
            }

        }

        public void minimum(bool[] indices, int[] value, int size)
        {
            int minval = int.MaxValue;
            for(int i = 0; i < size; i++)
            {
                if(indices[i] && minval > value[i])
                    minval = value[i];
            }

            for(int i = 0; i < size; i++)
            {
                if(indices[i] && minval != value[i])
                    indices[i] = false;
            }

        }
    }
}