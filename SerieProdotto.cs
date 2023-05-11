using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        int lunghezza= digits.Length;
        int prodmassimo=0; 
        int tent=1;

        if(span>lunghezza)
        {
            throw new System.ArgumentException();
        }
        else if(span<0)
        {
            throw new System.ArgumentException();
        }
        else if(span==0 && digits=="")
        {
            return 1;
        }
       
        for(int i = 0; i <= digits.Count() - span; i++)
        {
            for (int j = i; j < span + i; j++)
            {
                int vol = 0;
                int.TryParse(digits[j].ToString(), out vol);
                tent = tent * vol;
            }
           if(tent > prodmassimo)
            {
                prodmassimo = tent;
            }
            tent = 1;
        }

     return prodmassimo;
        
    }
    
}

    
