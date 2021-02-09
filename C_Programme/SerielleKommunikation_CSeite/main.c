/// Ersteller: Schulte Marc-Rafael
/// Projektbeschreibung: Empfängt Befehle über die Serielle Schnittstelle und verarbeitet dieses
/// Letzte Änderung: 09.02.2021 / 21.44 Uhr

#include <avr/io.h>
#include <avr/interrupt.h>
#include <stdlib.h>
#include "../../Library/myLib.h"
#include "../../Library/USART_SerielleSchnittstelle.h"

char readarray[20]="";

ISR(USART_RX_vect)
{
    uint8_t sreg = SREG;    ///Statusregister abspeichern
    cli();                  ///Interups deaktiviern, dass Routine nicht unterbrochen wird
    _gets(readarray);
    int i;

    if(readarray[0] == 'D')
    {
        for(i = 7; i >= 0; i--)
        {
            if(readarray[2+i] == '1')
            {
                DDRD |= (1<<i);
            }
            else
            {
               DDRD &= ~(1<<i);
            }
        }

        for(i = 0; i < 8; i++)
        {
            if(readarray[18-i] == '1')
            {
                PORTD |= (1<<i);
            }
            else
            {
               PORTD &= ~(1<<i);
            }
        }
    }
    else
    if(readarray[0] == 'C')
    {
        /// TO-DO
    }
    else
    {
        /// TO-DO
    }
}

int main(void)
{
    DDRD = 0b11111111;  /// Zur Sicherheit, kann in anderen Fällen weggelassen werden
    PORTD = 0b11111111; /// ""


    init_usart();
    sei();
    while(1)
    {

    }

    return 0;
}
