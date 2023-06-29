using System;

namespace App{

class Branch
    {
        List<Branch> branches;

        public Branch(){
            this.branches = new List<Branch>();
        }

        public int findDepth(){
            return findDepthHelper(this);
        }

        private int findDepthHelper(Branch cur){
            if(cur == null)
                return 0;
            else{
                int max = 0;
                foreach (var branch in cur.branches)
                {
                    int depth = findDepthHelper(branch);
                    if(depth > max)
                        max = depth;
                }
                return max + 1;
            }
        }

        public static void Main(String[] args){
            Branch b1 = new Branch();
            Branch b2 = new Branch();
            Branch b3 = new Branch();
            Branch b4 = new Branch();
            Branch b5 = new Branch();
            Branch b6 = new Branch();
            Branch b7 = new Branch();
            Branch b8 = new Branch();
            Branch b9 = new Branch();
            Branch b10 = new Branch();
            Branch b11 = new Branch();

            /*b1.branches.Add(b2);
            b1.branches.Add(b3);
            b2.branches.Add(b4);
            b3.branches.Add(b5);
            b3.branches.Add(b6);
            b3.branches.Add(b7);
            b5.branches.Add(b8);
            b6.branches.Add(b9);
            b6.branches.Add(b10);
            b9.branches.Add(b11);*/

            Console.WriteLine("Depth of tree is: " + b1.findDepth());
        }
    }
}