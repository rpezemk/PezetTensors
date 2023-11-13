﻿using PZWrapper.Types;
using ZImageTests.Process.Generics;
using ZImageTests.Types.Elementary;
using PZWrapper.Links;

namespace ZImageTests.Process.Simples
{
    public class SampleBlurNode : ANode<Matrix2D>
    {
        public SampleBlurNode() 
        {
            IsBypassed = true;
        }
       // public override string ProcessName => GetType().Name;
        public override ProcessResult<Matrix2D> Process(Matrix2D inputMatrix)
        {
            var blurIm = Marshaled.SampleBlur(inputMatrix);
            ProcessResult<Matrix2D> result = new ProcessResult<Matrix2D>();
            result.IsOk = true;
            result.ResBwIm = blurIm;
            return result;
        }

    }

}