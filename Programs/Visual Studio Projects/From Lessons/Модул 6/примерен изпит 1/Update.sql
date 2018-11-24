Update journeys
SET purpose =
(
	CASE 
    When id % 2 = 0
		Then 'Medical'
	when id % 3 = 0
		Then 'Technical'
	When id % 5 = 0
		THEN 'Educational'
	When id % 7 = 0
		Then 'Military'
	Else purpose
	End
)