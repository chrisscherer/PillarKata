// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
namespace BabysitterKata
{
	public class Babysitter
	{
		private int startTime;
		private int endTime;

		public int SetStartTime(int inputTime)
		{
			if(inputTime >= 0 && inputTime <= 0400)
				inputTime += 2400;

			if(inputTime < 1700)
				return -1;

			startTime = inputTime;
			return inputTime;
		}

		public int SetEndTime(int inputTime)
		{
			if(inputTime >= 0 && inputTime <= 0400)
				inputTime += 2400;

			if(inputTime < startTime || inputTime > 2800 || (inputTime > 0400 && inputTime < 1700))
				return -1;

			endTime = inputTime;
			return inputTime;
		}

		public int SetBedTime(int inputTime)
		{
			if(inputTime >= 0 && inputTime <= 0400)
				inputTime += 2400;

			if(inputTime > endTime || inputTime < startTime)
				return -1;

			return inputTime;
		}
	}
}

