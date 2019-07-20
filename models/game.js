module.exports = function(sequelize, DataTypes) {
  var Game = sequelize.define("Game", {
    highScore: {
      type: DataTypes.TIME
    },
    lapsFinished: {
      type: DataTypes.INTEGER
    }
  });

  Game.associate = function(models) {
    // We're saying that a Post should belong to an Author
    // A Post can't be created without an Author due to the foreign key constraint
    Game.belongsTo(models.User, {
      foreignKey: {
        allowNull: false
      }
    });
  };

  return Game;
};
