'Find a maximal sequence of consecutive zeros in a binary gap

Private Function solution(N As Integer) As Integer
    'variables
    Dim  binary as String
    Dim charBinary as String
    Dim maxsequencial as Integer = 0
    Dim sequencial as Integer = 0
    
    'convert int to binary
    binary = Convert.ToString(N, 2)
    'Console.WriteLine("Number:{0}, binary:{1}",N, binary)
    
    For i As Integer = 0 To binary.Length -1 
        charBinary = binary.Substring(i,1)
        if charBinary = "0" then
            sequencial +=1
        else
            if maxsequencial<sequencial then
                maxsequencial = sequencial
            end if   
            sequencial = 0
        end if
    next i
    return maxsequencial
    
    return 0
End Function