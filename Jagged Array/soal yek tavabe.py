def lesser_of_two_evens (a , b):
    
    #input("Give me two numbers: ")
    
    if a % 2 == 0 and b % 2 == 0:
        return min(a, b)
    else:
        return max(a,b)
            

print ("javab",lesser_of_two_evens(20,22)) 
    
    
    
    