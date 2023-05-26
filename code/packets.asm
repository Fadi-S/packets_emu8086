DATA SEGMENT
    PACKETS          DW    0
    NUMBER           DW    1       ; NUMBER OF TRANSMITTED PACKETS
    TRANSMISSIONS    DW    0


#start=PacketTransmission.exe#


name "packets"   

CODE SEGMENT
                           
START:     MOV AX,0
           OUT 112,AX
           IN AX, 110
           MOV PACKETS,AX                          

REPEAT:    INC TRANSMISSIONS
           MOV CX,NUMBER
           SUB PACKETS,CX
           CMP PACKETS,0
           JLE BREAK
       
           CMP NUMBER,64
           JB  MULTIPLY
INCREMENT: INC NUMBER
           JMP OUT
       
MULTIPLY:  SHL NUMBER,1        ; Multiply number by 2

OUT:       CMP  NUMBER,128
           JNE  REPEAT
           MOV  NUMBER,1
           JMP  REPEAT

BREAK:     MOV AX,TRANSMISSIONS
           OUT 112,AX

CODE ENDS

hlt