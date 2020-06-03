namespace djb2
{
    public static class Djb2{
        
        
        public static int run(string input){
            int hash = 5381;
            
            foreach(int c in input.ToCharArray()){
                unchecked{
                    hash = ((hash << 5) + hash )+c;
                }
            }
            
            return hash;
        }
    }
}
