def has_33(num):
    
    for i in range(1 , len(num) - 1):
        
        if num[i:i+2] == [3,3]:
            return True
        
    else:
        return False    
    
print ("javab",has_33([1,2,3,3,4,5]))    
    