import React from 'react'
import {Image} from 'react-bootstrap'
import banner from './bee-banner.jpg'
import {Circle} from 'rc-progress'


class UserDash extends React.PureComponent {
    constructor(props) {
        super(props);
        this.state = {
            percent: 0,
            userScore: 86
        }

        this.increase = this.increase.bind(this);
    }

    componentDidMount() {
        this.increase();
    }

    increase() {
        const percent = this.state.percent + 1;
        if (percent >= this.state.userScore) {
            clearTimeout(this.tm);
            return;
        }
        this.setState({ percent });
        this.tm = setTimeout(this.increase, 10);
    }

    render() {
        return(
            <React.Fragment>
            <header>
                <Image className="banner" responsive src={banner}/>
                <Circle className="progress-circle" percent={this.state.percent} strokeWidth="6" strokeColor="#5cb85c" />
            </header>
            <section>

            </section>
            </React.Fragment>
        )
    }

}

export default UserDash;