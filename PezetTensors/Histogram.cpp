#include "pch.h"
#include "Histogram.h"
#include <cstdint>
#include "PZMath.h"

int* GetHistogram(int width, int height, double* inValues)
{

	int* histValues = new int[UINT16_MAX];

	for (int i = 0; i < UINT16_MAX; i++)
		histValues[i] = 0;

	int totalLen = width * height;

	for (int c = 0; c < totalLen; c++) 
	{
		int currIdx =Clip((int)(inValues[c]), 0, UINT16_MAX - 1);
		histValues[currIdx] += 1;
	}

	return histValues;
}


int* Get2DHistogram(int width, int height, double* inValues)
{

	int histHeight = width;
	int* histValues = new int[width*1024];
	// hist is image of width = width and height = 1024
	// histogram from column c is placed in column c in 2DHistogram.

	int totalHistLen = width * 1024;

	for (int i = 0; i < totalHistLen; i++)
		histValues[i] = 0;


    int randMax = 250;
	int currRand = 9;
    for (int c = 0; c < width; c++) 
	{
		for (int r = 0; r < height; r++)
		{
			currRand = 0;// (currRand * 111 + 1) % randMax;
			int resRow = Clip(((int)(inValues[r * width + c]) + currRand), 0, UINT16_MAX) / 64;
			histValues[resRow*width + c] += 1;
		};
	}

	int max = 0;
	for (int i = 0; i < totalHistLen; i++)
	    if(histValues[i] > max)
			max = histValues[i];

	int coeff = UINT16_MAX / max;

	for (int i = 0; i < totalHistLen; i++)
		histValues[i] = histValues[i] * coeff;
	



	//int x1 = UINT16_MAX / 4;
	//int y1 = (UINT16_MAX) / 4;
	//auto kneeCoeff = (float)y1 / (float)x1;
	//auto afterKneeCoeff = (float)(UINT16_MAX - y1) / (float)(UINT16_MAX - x1);
	//for (int i = 0; i < totalHistLen; i++)
	//{
	//	int val = histValues[i];
	//	val = val < x1 ? (int)(val * kneeCoeff) : ((int)((val- y1) * afterKneeCoeff)) + y1;
	//	histValues[i] = val;
	//}


	return histValues;
}



