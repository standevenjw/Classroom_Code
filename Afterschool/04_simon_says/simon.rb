def echo w
	w
end

def shout w
	w.upcase
end

def repeat w, n = 2
	(w + " ") * (n - 1) + w
end

def start_of_word w, n
	w.slice(0..(n - 1))
end

def first_word w
	w.slice(0..((w.index(' ')) - 1))
end

def capitalize w
	w.capitalize
end

def titleize w
	w.split(' ').map{|w1| w1.capitalize}.join(' ')
end
