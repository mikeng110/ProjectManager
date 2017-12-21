.global main
main:
   MOV R7, #4
   MOV R0, #1
   LDR R2, =len
   LDR R1, =string
   SWI 0
   MOV R7, #1
   SWI 0
.data

string:
.ascii "Hello World?\n"
len = . - string
