using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays_In_Csharp
{
    internal class Arrays
    {
        int[] arr;

        public Arrays(int[] arr)
        {
            
            this.arr = arr;
            
        }
        public int getLength()
        {
            return arr.Length;
        }

        public void getMaxAndMin()
        {
            int iMax=0,iMin=0;

            for(int i = 0 ;i < arr.Length;i++)
            {
                if (arr[i] >= iMax)
                {
                    iMax = arr[i];
                }
                else
                {
                    iMin = arr[i];
                }
            }

            Console.Write("\nIn Given Array Max number is {0} and Minimum is {1}",iMax,iMin);
        }

        public void getNegative()
        {

            int iCnt = 0;
            for (iCnt = 0; iCnt < arr.Length; iCnt++)
            {
                if (arr[iCnt] < 0)
                {
                    break;
                }
            }
            if (iCnt == arr.Length)
            {
                Console.Write("\nThere No Negative Numbers in Array !!!!!!");
            }
            else
            {
                Console.Write("\nNegative Numbers are :");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        Console.Write("\t" + arr[i]);
                    }

                }
            }
        }

        public void getSumOfArray()
        {
            int iSum = 0;
        
            for (int i = 0; i < arr.Length; i++)
            {

                iSum += arr[i];

            }
            
            Console.Write("\nSum of Arry is : " + iSum);
                 
        }


        public void prntArr()
        {
            Console.Write("\nElements are: ");
            foreach (int i in arr)
            {
                Console.Write("\t"+i);
            }
        }

        public void getDigitCnt()
        {
            for(int i = 0;i < arr.Length; i++)
            {
                int iCnt=0,iNo = arr[i];
               
                while(iNo != 0)
                {
                    iNo/=10;
                    iCnt++;
                }
                Console.Write("\nElement {0} having {1} Digits",i, iCnt);
                
            }
        }


        public void sortArray()
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = this.arr[i];
                        this.arr[i] = this.arr[j];
                        this.arr[j] = temp;
                    }

                }

            }
            Console.Write("\nSorted Array is : ");
            prntArr();

        }



    }
}
