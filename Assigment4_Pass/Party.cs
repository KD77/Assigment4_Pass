using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4_Pass
{
    // hello
    class Party
    {
        private double costPerCapita;
        private string[] guestList;

        public Party(int maxNumOfGuests)
        {
            guestList = new string[maxNumOfGuests];

        }
        public double CostPerCapita
        {
            get
            {
                return costPerCapita;
            }
            set
            {
                if (value >= 0)
                    costPerCapita = value;
            }
        }
        private  int NumOfGuests()
        {
            int numGuests = 0;
            for (int i=0; i<guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }
            return numGuests;
        }
        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();
            if (vacantPos != -1)
            {
                guestList[vacantPos] = FullName(firstName, lastName);
            }
            else
                ok = false;


            return ok;
        }
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + "," + firstName;

        }
        private int FindVacantPos()
        {
            int vacantPos = -1;
            for(int index=0; index< guestList.Length; index++)
            {
                if (string.IsNullOrEmpty(guestList[index]))
                {
                    vacantPos = index;
                    break;

                }
            }

            return vacantPos;
        }
        public string [] GetGuestList()
        {
            int size = NumOfGuests();

            if (size <= 0)
                return null;
            string[] guests = new string[size];

            //j is for size 
            for (int i = 0,j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j++] = guestList[i];

                }
            }
            return guests;
        }
        public bool DeleteAt(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                guestList[index] = string.Empty;
                MoveElementsOneStepToLeft(index);
                ok = true;
            }
            return ok;
        }
        private void MoveElementsOneStepToLeft(int index)
        {
            for(int i=index+1; i< guestList.Length; i++)
            {
                guestList[i - 1] = guestList[i];// move 1 step to left
                guestList[i] = string.Empty;// empty its place

            }
        }
        public bool CheckIndex(int index)
        {
            return(index >= 0) && (index < guestList.Length);
        }
    }
}
