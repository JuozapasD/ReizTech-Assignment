using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_Assignment;


    public class Branch
    {
        // We need a list and method to count the layers in the branches
        public List<Branch> branches = new List<Branch>();
        public int CalculateDepth()
            {
        // If branch list has no branches it only has root ( the first layer ),
        // we check if it is true and return one (as there is only one layer)
        if (branches.Count == 0)
        {
            return 1;
        }
        else
        {
         // Create a variable in which we will store information
         int Depth = 0;

                // Check the Branch list items and increase the Depth number if Branch has branches.
                foreach (Branch item in branches)
                {
                    int subBranchDepth = item.CalculateDepth();
                    if (subBranchDepth > Depth)
                    {
                        Depth = subBranchDepth;
                    }
                }
                return Depth + 1;
            }

        }
    }


