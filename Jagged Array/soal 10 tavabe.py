def summer_69(lst):
    
    total = 0
    add = True
    
    for num in lst:
        while add:
            if num != 6:
                total += num
                break
            else:
                add = False
        
        while not add:
            if num != 9:
                break
            else:
                add = True
                break
            
    return total

print ("Javab", summer_69([1,2,3,4,5,6,7,8,9]))
    
    
    