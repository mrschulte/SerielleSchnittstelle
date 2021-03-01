/*
 */

#include <avr/io.h>
#include "myLib.h"
#include "USART_SerielleSchnittstelle.h"
#include <avr/interrupt.h>
#include <stdlib.h>

uint8_t on = 0;
char cmd[10] = "";

ISR(USART_RX_vect)
{
    uint8_t sreg = SREG;
    cli();
    _gets(cmd);
    on = 1;
    SREG = sreg;
}


int main(void)
{
    DDRD = 0b01000000;
    init_usart();
    ADC_init();
    sei();
    TCCR0B |= 1;
    TCCR0A = 0x83; // 0b10000011
    OCR0A = 127;

    uint16_t wert = 0;
    char str[] = "Halloo";

    while(1)
    {
        if(on)
        {
            wert = ADC_Lesen();
            itoa(wert, str, 10);
            serialWrite(str);
            myDelay(100);
        }
    }

    return 0;
}
