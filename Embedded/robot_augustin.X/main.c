#include <stdio.h>
#include <stdlib.h>
#include <xc.h>
#include "ChipConfig.h"
#include "IO.h"
#include "timer.h"
#include "PWM.h"

int main(void) {
    /***************************************************************************************************/
    //Initialisation de l?oscillateur
    /****************************************************************************************************/
    InitOscillator();

    /****************************************************************************************************/
    // Configuration des entrées sorties
    /****************************************************************************************************/
    InitIO();

    InitTimer23();

    InitTimer1();

    InitPWM();

    InitADC1();

    //        PWMSetSpeed(30, 1);
    //        PWMSetSpeed(-30, 0);

    PWMSetSpeedConsigne(40, 1);
    PWMSetSpeedConsigne(40, 0);

    LED_BLANCHE = 1;
    LED_BLEUE = 1;
    LED_ORANGE = 1;

    /****************************************************************************************************/
    // Boucle Principale
    /****************************************************************************************************/
    while (1) {

    } // fin main
}
