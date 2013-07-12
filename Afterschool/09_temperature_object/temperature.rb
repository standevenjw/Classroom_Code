class Temperature
  
  def self.from_celsius temp
    new(:c => temp)
  end

  def self.from_fahrenheit temp
    new(:f => temp)
  end

  def initialize options ={}
    @fahrenheit = options[:f] || options[:c] * (9 / 5.0) + 32
	@celsius = options[:c] || (options[:f] - 32) * 5 / 9.0
  end
  
  def in_celsius
    @celsius
  end
  
  def in_fahrenheit 
    @fahrenheit
  end
end

class Celsius < Temperature
  def initialize temp
    super(:c => temp)
  end
end
  
class Fahrenheit < Temperature
  def initialize temp
    super(:f => temp)
  end
end
  