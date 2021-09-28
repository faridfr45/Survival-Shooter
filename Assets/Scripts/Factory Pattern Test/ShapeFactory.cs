using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShapeFactory 
{
	
   //use getShape method to get object of type shape 
   public Shape getShape(String shapeType){
      if(shapeType == null){
         return null;
      }		
      if(string.Equals(shapeType, "CIRCLE",  StringComparison.OrdinalIgnoreCase)){
         return new Circle();
         
      } else if(string.Equals(shapeType, "RECTANGLE",  StringComparison.OrdinalIgnoreCase)){
         return new Rectangle();
         
      } else if(string.Equals(shapeType, "SQUARE",  StringComparison.OrdinalIgnoreCase)){
         return new Square();
      }
      
      return null;
   }
}
