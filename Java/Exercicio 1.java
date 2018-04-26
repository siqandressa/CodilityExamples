// you can also use imports, for example:
// import java.util.*;

// you can write to stdout for debugging purposes, e.g.
// System.out.println("this is a debug message");

class Solution {
    public int solution(int N) {
        //variables
        String binary;
        String charBinary;
        int maxsequencial=0;
        int sequencial=0;

        //convert int to binary
        binary = Integer.toBinaryString(N);
        //System.out.println("Number:" + N + ", binary:" + binary);
        
        for(int i=0; i< binary.length(); i++){
            if(binary.charAt(i) == '0'){
                sequencial +=1;        
            }
            else{
                if(maxsequencial<sequencial){
                    maxsequencial = sequencial;
                }   
                sequencial = 0;
            }
            
        }
        return maxsequencial;
    }
}