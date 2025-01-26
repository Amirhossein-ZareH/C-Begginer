def black_jack(a, b, c):
    
    if 1 <= a and b and c <= 11:
        
        if (a+b+c) <= 21:
            return (a+b+c)
        elif (a+b+c) > 21 and 11 in (a,b,c):
                return (a+b+c) - 10
        else:
            return ("Bust")
            
print ("Javab", black_jack(9,9,9))    
    
    
    