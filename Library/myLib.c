#include <avr/io.h>
void myDelay(uint32_t ms)
{
    ms*=373;
    while(ms--);
}
