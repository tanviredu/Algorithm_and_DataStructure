namespace addtive_hash
{
    public static  class Addtive_hash {
        
        public static int run(string input){
            int currenthashValue = 0;
            
            foreach (char c in input){
                
                unchecked{
                    currenthashValue += (int)c; // find the ascii value and add
                }
            }
            return currenthashValue;
        }
        
    }
}
