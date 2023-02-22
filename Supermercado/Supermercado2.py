#supermercado python con logica
import sys
#import re

conta = int(0)
while True:
    try:
      cad = input()
    except EOFError:
      break
    
    if not cad:
        # la cadena vacia...
        sys.exit()
    else:
        es = ' '
        tab = '\t'
        conta = 0
        local = str()
        nocad = str()
        
        for i in range(0, len(cad), 1):
            if cad[i] != es and cad[i] != tab:
                local = local + cad[i]
                if i == len(cad)-1:
                    conta = conta + int(local)
            else:
                if local != nocad:
                    conta = conta + int(local)
                    local = str()
        print(conta)
#end program