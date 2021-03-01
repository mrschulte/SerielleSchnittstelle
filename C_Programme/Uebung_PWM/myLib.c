#include <avr/io.h>
void myDelay(uint32_t ms)
{
    ms*=373;
    while(ms--);
}

uint16_t ADC_Lesen(void)
{
    uint16_t x = 0;
    ADCSRA |= (1<<ADSC);
    while(ADCSRA & (1<<ADSC));
    x = ADCL;
    x += (ADCH << 8);
    return x;
}

void ADC_init(void)
{
    ADMUX = 0b01000000;
    ADCSRA |= 0b00000111;
    ADCSRA |= (1<<ADEN);
}
