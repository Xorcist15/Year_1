SELECT A.id, A.nom, COUNT(DISTINCT 
FROM acteurs A
JOIN distributions D ON D.idacteur = A.id
ORDER BY id