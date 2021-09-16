/* 
 * File:   adc.h
 * Author: Table2
 *
 * Created on 10 septembre 2021, 15:08
 */

#ifndef ADC_H
#define	ADC_H

void InitADC1(void);

unsigned int * ADCGetResult(void);

unsigned char ADCIsConversionFinished(void);

void ADCClearConversionFinishedFlag(void);

void ADC1StartConversionSequence(void);

#endif

