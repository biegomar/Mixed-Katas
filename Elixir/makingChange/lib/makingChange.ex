defmodule MakingChange do
  def make_change(amount) do
      #H, Q, D, N and P
      #50¢, 25¢, 10¢, 5¢ and 1¢
      result = %{}      
      if(amount != 0) do        
        h = div(amount, 50)
        if(h > 0) do
            amount = amount - h*50
            result = Map.put(result, :H, h)
        end                
        q = div(amount, 25)
        if(q > 0) do
            amount = amount - q*25
            result = Map.put(result, :Q, q)    
        end        
        d = div(amount, 10)
        if(d > 0) do
            amount = amount - d*10
            result = Map.put(result, :D, d)    
        end        
        n = div(amount, 5)
        if(n > 0) do
            amount = amount - n*5
            result = Map.put(result, :N, n)    
        end
        if(amount > 0) do
            result = Map.put(result, :P, amount)    
        end                                  
      end        
      result      
  end    
end
