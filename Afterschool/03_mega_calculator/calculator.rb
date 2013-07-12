def add n1, n2
	n1 + n2
end

def subtract n1, n2
	n1 - n2
end

def sum n
	n.reduce(0){|sum,n| sum + n}
end

def multiply *n
	n.inject(1){|multiply,n| multiply * n}
end

def factorial n
	n < 1 ? 1 : n.downto(1).inject{|factorial, n| factorial * n}
end