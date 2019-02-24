interface Yuri() {
    /*
    The main API methods that users of this class need to know are:
        step
        reset
        render
        reward
    And set the following attributes:
        action_space: The Space object corresponding to valid actions
        observation_space: The Space object corresponding to valid observations
    */

    private:
        Actions action_space;
        Observations observation_space;
        bool done = False;

    public:
        virtual float reward(Observation observation) {
            /*
            Args:
                observation (object): agent's observation of the current environment
            Returns:
                reward (float) : amount of reward returned after previous action
            */
            throw new NotImplementedException();
        }


        virtual  GameIteration step(Action action) {
            /*Run one timestep of the game
            Accepts an action and returns a tuple (observation, reward, done).
            Args:
                action (enum): an action provided by the environment
            Returns:
                observation (object): agent's observation of the current environment
                reward (float) : amount of reward returned after previous action
                done (boolean): whether the episode has ended, in which case further step() calls will return undefined results
            */
            throw new NotImplementedException();
        }

        virtual void reset() {
            /*Resets the state of the environment and returns an initial observation.
            Returns: observation (object): the initial observation of the
                space.
            */
            throw new NotImplementedException();
        }

        virtual void render(string mode='human') {
           /*
            Args:
                mode='human' to play against the bot
            */
            throw new NotImplementedException();
        }
}
