//Find a maximal sequence of consecutive zeros in a binary gap

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {

        //variables
        string binary;
        string charBinary;
        int maxsequencial=0;
        int sequencial=0;

        //convert int to binary
        binary = Convert.ToString(N, 2);
        //Console.WriteLine("Number:" + N + ", binary:" + binary);

        for(int i=0; i<binary.Length; i++){
            charBinary = binary.Substring(i,1);
            if(charBinary == "0"){
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