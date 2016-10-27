using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1A2B
{
    class MANB
    {
        private string oldStr;
        public string STR
        {
            set 
            {
                oldStr = value;
            }
            get
            {
                return oldStr;
            }
        }
        private Random random;
        private int[] arr;

        public MANB()
        {
            arr = new int[10];
            random = new Random();
            oldStr = produce();
        }

        public string check(string newStr)
        { 
            int a = 0, b =0;
            char[] oldChar = oldStr.ToCharArray();
            char[] newChar = newStr.ToCharArray();
		    for(int i=0 ; i<4 ; ++i) {
			    for(int j=0 ; j<4 ; ++j) {
                    if(oldChar[i] == newChar[i]){
					    ++a;
					    break;
				    }
				    if(oldChar[i] == newChar[j]) {
					    ++b;
					    break;
				    }
			    }
		    }
            return a + "A" + b + "B";
     }

        public string produce()
        {
            string str = null;
            for (int i = 0; i < 4; ++i)
            {
                int t = 0;
                do{
                    t = random.Next(0, 10);
                }while (arr[t] != 0);
                arr[t] = 1;
                str += t;
            }
            return str;
        }

        public bool verify(string newStr)
        {
            return oldStr.Equals(newStr);
        }
    }
}
