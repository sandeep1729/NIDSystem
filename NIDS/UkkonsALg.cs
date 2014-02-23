using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class UkkonsALg
    {
        public string algorthm(string tree)
        {

            string mainsuffix = tree;
            int len = tree.Length;
            for(int i=0;i<tree.Length;i++)
            {
                if (i != tree.Length)
                {
                    mainsuffix =  mainsuffix + tree.Substring(i, len);
                    len--;
                    if (len == 0)
                        break;
                        

                }
                else if (i == tree.Length)
                {
                    break;
                }
                
   
            
            }
            return mainsuffix;
        
        }
    }
}
