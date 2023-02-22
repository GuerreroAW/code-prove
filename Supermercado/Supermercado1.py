#supermercado python con regex
import sys
import re

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
        cad_strip = cad.strip()
        cad_split = re.split("\s+", cad_strip)
        conta = 0;
        for i in range(0, len(cad_split), 1):
            conta = conta + int(cad_split[i])
        print(conta)
#end program