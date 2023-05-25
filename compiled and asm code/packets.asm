DATA SEGMENT
    PACKETS  DW    0
    FINISHED DW    0       ;NUMBER OF TRANSMITTED PACKETS AND DETECT 128 CYCLE
    TRANS    DW    0


#start=PacketTransmition.exe#


name "packets"   

CODE SEGMENT
                           
START: MOV AX,0
       OUT 112,AX
       IN AX, 110
       MOV PACKETS,AX                          


REPEAT:INC TRANS
       INC FINISHED
       DEC PACKETS
       
       CMP FINISHED,64
       JB  ELSE     
       
       INC FINISHED
       DEC PACKETS 
       JMP DONE 
       
ELSE:  MOV CX,FINISHED 
       CMP CX,PACKETS
       JAE BREAK
       SHL FINISHED,1   
       SUB PACKETS,CX


DONE:  CMP  PACKETS,0
       JB   BREAK
       JE   BREAK
       CMP  FINISHED,128
       JNE  END
       MOV  FINISHED,0
END:   JMP  REPEAT  


BREAK: MOV AX,TRANS
       OUT 112,AX

CODE ENDS

hlt