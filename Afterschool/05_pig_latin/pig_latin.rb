def translate s
	a = "ay"
	s.split.map! { |s1|
		if s1[0] == 'q' then
			s1[s1.index(/[aeio]/)..-1] + s1[0..s1.index(/[aeio]/) - 1] + a
		elsif s1[0] == 'y' then
			s1[s1.index(/[aeiou]/)..-1] + s1[0..s1.index(/[aeiou]/) - s1.length - 1] + a
		else
			s1[s1.index(/[aeiouy]/)..-1] + s1[0..s1.index(/[aeiouy]/) - s1.length - 1] + a
		end
	}.join(' ')
end