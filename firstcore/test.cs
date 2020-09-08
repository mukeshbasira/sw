
using System;
using Xunit;
using firslib;
namespace firstcore
{
    public class test
    {
        [Fact]
        public void add()
        {
        //Given
        var p = new operation();
       
        Assert.Equal( p.addition(5,6),11);
       
        //When
        
        //Then
        }

         [Fact]
        public void sub()
        {
        //Given
        var p = new operation();
       
        Assert.Equal( p.subtraction(5,6),-1);
       
        //When
        
        //Then
        }
        
        
    }
}