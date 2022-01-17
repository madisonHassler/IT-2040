#include<stdio.h>
 
 int main(void){
 
     for (int i=1; i<=100; i++){
 
         if ((i % 3) == 0 && (i % 5) == 0){ /*test if divisible by 3 and 5*/
             printf("FizzBuzz\n");
         }
         else{
             if ((i % 5) == 0){ /*if not divisible by 3 and 5, test if divisible by only 5*/
                 printf("Bizz\n");
             }
             else{
                 if ((i % 3) == 0){ /*if not divisible by 5, test if divisible by only 3*/
                     printf("Fizz\n");
                 }
                 else{ /*if not divisible by (3 & 5), 5, or 3, print integer*/
                     printf("%d\n", i);
                 }
             }
         }
     }
 return 0;
 }

