Select id, username
from users
order by id asc;

SELECT *
FROM repositories_contributors
WHERE contributor_id = repository_id
ORDER BY repository_id;

Select id, name, size
from files 
where size>1000 and name like '%html%'
order by size desc;

Select i.id,
concat(u.username,' : ', i.title) as issue_assignee
from issues as i
join users as u on u.id = i.assignee_id
order by i.id desc;

Select f.id, f.name, concat(f.size, 'KB') as size
from files as f
LEFT JOIN files AS p ON f.id = p.parent_id
where p.id IS NULL;

Select r.id, r.name, count(i.id) as issues
from repositories as r
Join issues as i on i.repository_id = r.id
Group by r.id
order by issues desc, r.id asc
Limit 5;

Select rc.repository_id as id, r.name,
count(c.id) as commits,
count(rc.contributor_id) as contributors
from repositories_contributors as rc
Join commits as c on rc.repository_id = c.repository_id
Group by rc.repository_id
Order by contributors desc, r.id asc
Limit 1;

Select cn.id, r.name,
count(c.id) as commits,
cn.contributors
from
(
	select 
    rc.repository_id as id,
    count(rc.contributor_id) as contributors
    from repositories_contributors as rc
    Group by rc.repository_id
) as cn
Join repositories as r on cn.id = r.id
Left Join commits as c on cn.id = c.repository_id
Group by cn.id
Order by contributors desc, r.id asc
Limit 1;


