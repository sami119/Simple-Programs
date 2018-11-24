Select card_number, job_during_journey From travel_cards order by card_number asc;

SELECT id, concat(first_name, ' ', last_name) as full_name, ucn from colonists order by first_name, last_name, id asc;

SELECT id, journey_start, journey_end 
from journeys 
where purpose = 'Military'
order by journey_start asc;

SELECT c.id, concat(c.first_name, ' ', c.last_name) as full_name
from colonists as c
Join travel_cards as tc on c.id = tc.colonist_id
Where tc.job_during_journey = 'Pilot'
order by id asc;

Select count(*) as count 
from colonists as c
Join travel_cards as tc on tc.colonist_id = c.id
Join journeys as j on j.id = tc.journey_id
Where j.purpose = 'Technical';

Select sh.name as spaceship_name, sp.name as spaceport_name 
from spaceships as sh 
join journeys as j on j.spaceship_id = sh.id
join spaceports as sp on sp.id = j.destination_spaceport_id
Order by sh.light_speed_rate desc limit 1;

Select sh.name, sh.manufacturer
from spaceships as sh
Join journeys as j on j.spaceship_id = sh.id
Join travel_cards as tc  on tc.journey_id = j.id
Join colonists as c on c.id = tc.colonist_id
where tc.job_during_journey = 'Pilot' and 2019 - year(c.birth_date) < 30
order by sh.name asc;

Select p.name as planet_name, sp.name as spaceport_name
from planets as p
join spaceports as sp on sp.planet_id = p.id
join journeys as j on j.destination_spaceport_id = sp.id
where j.purpose = 'Educational'
order by spaceport_name desc;

Select * From
(
	Select p.name as planet_name,
    (
		Select count(*) as count
		from journeys as j
		join spaceports as sp on j.destination_spaceport_id = sp.id
		where p.id = sp.planet_id
        having count > 0
	)as journeys_count
	From planets as p
	order by journeys_count desc, p.name asc
)as c
where c.journeys_count is not null;

Select j.id, p.name as planet_name, sp.name as spaceport_name, j.purpose
From journeys as j
Join spaceports as sp on sp.id = j.destination_spaceport_id
Join planets as p on sp.planet_id = p.id
Where j.id =
(
	Select jr.id
    from journeys as jr
    ORDER BY DATEDIFF(jr.journey_start, jr.journey_end) DESC
    Limit 1
);

SELECT tc.job_during_journey AS job_name
FROM travel_cards AS tc
WHERE tc.journey_id =
(
	SELECT j.id
    FROM journeys AS j
    ORDER BY DATEDIFF(j.journey_start, j.journey_end) ASC
    LIMIT 1
)
GROUP BY job_name
ORDER BY COUNT(*) ASC
LIMIT 1;