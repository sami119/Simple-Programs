insert into travel_cards(card_number, job_during_journey, colonist_id, journey_id)
Select
(
	Case WHEN birth_date > '1980-01-01'
		Then Concat(year(birth_date), day(birth_date), substr(ucn, 1, 4))
        Else concat(year(birth_date), month(birth_date), substr(ucn, 7, 10))
        END
) AS card_number,
(
	Case WHEN id % 2 = 0
		THEN 'Pilot'
	WHEN id % 3 = 0
		Then 'Cook'
	Else 'Engineer'
    End
) as job_during_journey,
id as colonist_id,
substr(ucn, 1, 1) as jouney_id
from colonists where id between 96 and 100;