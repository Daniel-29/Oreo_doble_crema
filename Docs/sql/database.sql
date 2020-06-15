
/* database: arkanoid_db */

CREATE TABLE player(
	id_player SERIAL,
	nickname VARCHAR(50) NOT NULL,
	lifes INT NOT NULL,
	creation_date DATE DEFAULT CURRENT_DATE,
	creation_time TIME DEFAULT CURRENT_TIME,
	PRIMARY KEY(id_player)
);
CREATE TABLE game(
	id_game SERIAL,
	id_player INT NOT NULL,
	score INT DEFAULT 0,
	duration VARCHAR(10) DEFAULT '00:00:00"',
	game_date DATE DEFAULT CURRENT_DATE,
	game_time TIME DEFAULT CURRENT_TIME,
	PRIMARY KEY (id_game),
	FOREIGN KEY (id_player) REFERENCES player(id_player)
);