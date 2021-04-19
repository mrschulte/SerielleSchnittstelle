/*
*   Im C#-Programm sind buttons zum An- bzw Ausschalten. Dadurch schaltet der Mosfet an PD4 durch. Zusätzlich wird das Messen gestartet
*/

#include <avr/io.h>
#include "../../Library/myLib.h"
#include "../../Library/USART_SerielleSchnittstelle.h"
#include <avr/interrupt.h>
#include <string.h>

char readarray[20] = "";
char startvergleich[] = "start";
char stopvergleich[] = "stop";
uint8_t state = 0;
uint16_t wert;
char string[]= "Platz";

ISR(USART_RX_vect)
{
    uint8_t sreg = SREG;
    cli();
    _gets(readarray);
    if(strcmp(startvergleich, readarray) == 0)  // 0 = gleich , alles > 0 = verschieden
    {
        PORTD = 0b00010000;
        state = 1;
    }
    else
    if(strcmp(stopvergleich, readarray) == 0)
    {
        PORTD = 0b00000000;
        state = 0;
    }
    SREG = sreg;
}


int main(void)
{
    DDRD = 0b11111111;
    PORTD = 0b00000000;

    ADCSRA |= 0b00000111;   /// Wander aus, Teiler 111
    ADCSRA |= (1<<ADEN);    /// Wandler an


    init_usart();
    sei();

    while(1)
    {
        if(state)
        {
            Messung();
            myDelay(100);
        }

    }

    return 0;
}

void Messung()
{
    ADMUX = 0b01000001;             /// Ref. Spannung AVcc, Ausrichtung rechts, Kanal A1

    ADCSRA |= (1<<ADSC);            /// Wander ein
    while(ADCSRA & (1<<ADSC));      /// Warten bis Wander wieder auf 0 ist

    wert = ADCL;                    /// Spannung auslesen
    wert += (ADCH<<8);

    itoa(wert, string, 10);
    _puts(string);            /// Verschicken
}
